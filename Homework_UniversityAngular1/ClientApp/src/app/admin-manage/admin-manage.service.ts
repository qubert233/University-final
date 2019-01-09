import { Component, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Admin} from './admin';
import { User } from '../_models';

@Injectable()
export class DataService {

  private url = "/api/adminmanage";

  constructor(private http: HttpClient) {
  }

  getAdmins() {
    //return this.http.get(this.url);
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    var token = obj.token;
    return this.http.post<any>(this.url, { "token": token });
  }
}
