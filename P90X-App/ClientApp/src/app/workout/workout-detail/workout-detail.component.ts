import { Component, OnInit, Input } from '@angular/core';
import { Workout } from '../workout.model';
import { Exercise } from '../exercise.model';
import { ExerciseService } from '../exercise.service';
import { WorkoutService } from '../workout.service';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-workout-detail',
  templateUrl: './workout-detail.component.html',
  styleUrls: ['./workout-detail.component.css']
})
export class WorkoutDetailComponent implements OnInit {
  id: string;
  workout: Workout;
  workoutExercises: Exercise[] = [];
  //inject from service
  constructor(private workoutService: WorkoutService,
              private exerciseService: ExerciseService,
              private router: Router,
              private route: ActivatedRoute ) { }

  ngOnInit() {
    this.route.params.subscribe(
      async (params: Params) => {
        this.id = params.id;
        this.workout = this.workoutService.getWorkout(this.id);
      }
    )};

    checkValue(event: any){
      console.log(event);
   }
}
