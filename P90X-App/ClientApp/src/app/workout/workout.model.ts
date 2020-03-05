import { Injectable } from '@angular/core';

@Injectable()

export class Workout {

    constructor(
        public id: string,
        public workoutTitle: string,
        public exerciseTitle: string,
        public reps: number,
        public weight: number,
        public side: string,
        public workoutStatus: string,
        public dietStatus: string,
        //workoutBlock : workoutBlock
        public workoutBlock: string
    ) {}
}