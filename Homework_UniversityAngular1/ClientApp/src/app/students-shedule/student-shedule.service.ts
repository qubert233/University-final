import { Component, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from './student-shedule';
import { User } from '../_models';

@Injectable()
export class DataService {

  private url = "/api/studentshedule";

  constructor(private http: HttpClient) {
  }

  getStudents() {
    //return this.http.get(this.url);
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    var token = obj.token;
    return this.http.post<any>(this.url, { "token": token });
  }
}
