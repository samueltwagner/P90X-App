import { Injectable, EventEmitter } from '@angular/core';
import { Exercise } from './exercise.model';
import { Subject } from 'rxjs';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

@Injectable({ providedIn: 'root'})

export class ExerciseService {
  exercises: Exercise[] = [];
  exerciseListChangedEvent = new Subject<Exercise[]>();

  constructor(private http: HttpClient) {}

  sortAndSend() {
    this.exerciseListChangedEvent.next(this.exercises.slice());
  }

  //GET
  getExercises() {
    return this.http.get<{ message: string, exercises: Exercise[] }>
    // MONGO ATLAS API CONNECTION STRING: mongodb+srv://admin:Password1234@p90x-xaviq.mongodb.net/test?retryWrites=true&w=majority
      ('https://localhost:5001/api/exercise/')
      .subscribe(
        (exerciseData) => {
          this.exercises = JSON.parse(JSON.stringify(exerciseData));
          this.sortAndSend();
        },
        (error: any) => {
          console.log(error);
        }
      );
  }

  getExercise(exerciseId: string): Exercise {
    if (this.exercises) {
      this.getExercises();
    }
    console.log(this.exercises)
    for (const exercise of this.exercises) {
      if (exercise.id === exerciseId) {
        return exercise;
      }
    }
    return null;
  }

  //POST
  addExercise(newExercise: Exercise) {
    if (!newExercise) {
      return;
    } else {
      newExercise.id = "";
      const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
      //add to database
      this.http.post<{ message: string, exercise: Exercise}>
        ('https://localhost:5001/api/exercise/',
          newExercise,
          { headers: headers })
        .subscribe(
          (responseData) => {
            //add new document to documents
            console.log(responseData);
            this.exercises.push(JSON.parse(JSON.stringify(responseData)));
            this.sortAndSend();
          }
        );
    }
  }

  //PUT Update
  updateExercise(originalExercise: Exercise, newExercise: Exercise) {
    if (!originalExercise  ||  !newExercise) {
      return;
    }
    const pos = this.exercises.indexOf(originalExercise);
    if ( pos < 0 ) {
      console.log('No negative indexes');
      return;
    }
    newExercise.id = originalExercise.id;

    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    //update database
    this.http.put('https://localhost:5001/api/exercise/' + originalExercise.id,
      newExercise, { headers: headers })
      .subscribe(
        (response: Response) => {
          this.exercises[pos] = newExercise;
          this.sortAndSend();
        }
      )
  }

}

