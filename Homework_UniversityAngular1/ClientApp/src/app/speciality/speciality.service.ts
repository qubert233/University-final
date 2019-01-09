import { Component, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Speciality } from './speciality';
import { User } from '../_models/user';

@Injectable()
export class DataService {

  private url = "/api/speciality";

  constructor(private http: HttpClient) {
  }
  getSpecialities() {
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    var token = obj.token;
    return this.http.post<any>(this.url, { "token": token } );
  }
}
