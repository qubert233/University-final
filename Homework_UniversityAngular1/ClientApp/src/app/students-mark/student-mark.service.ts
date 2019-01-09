import { Component, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student2 } from './student-mark';
import { User } from '../_models';

@Injectable()
export class DataService {

  private url = "/api/studentmark";

  constructor(private http: HttpClient) {
  }

  //getStudents() { 
  //  return this.http.get(this.url);
  //}
  getStudents() {
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    var token = obj.token;
    return this.http.post<any>(this.url, { "token": token });
    //return this.http.get(this.url);
  }
}
