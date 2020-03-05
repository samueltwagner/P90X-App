
import { Injectable } from '@angular/core';

@Injectable()

export class User {

    constructor(
        public id: string,
        public firstName: string,
        public lastName: string,
        public email: string,
        public password: string,
        public userWeight: number,
    ) {}
}

