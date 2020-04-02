import { Injectable } from '@angular/core';

@Injectable()

export class Workout {

    constructor(
        public id: string,
        public workout_id: string,
        public workoutTitle: string,
        public workoutStatus: boolean,
        public dietStatus: boolean,
        public dayNumber: number,
        public weekNumber: number,
        public blockNumber: number,
        public date_Workout_Completed: string,
        public exercise: string,
        public user: string
    ) {}
}