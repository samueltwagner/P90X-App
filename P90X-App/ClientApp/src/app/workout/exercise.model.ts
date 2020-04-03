import { Injectable } from '@angular/core';

@Injectable()

export class Exercise {

    constructor(
        public id: string,
        public exercise_Id: string,
        public exercise_Title: string,
    ) {}
}