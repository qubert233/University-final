import { Component, OnInit, Inject } from '@angular/core';
import { DataService } from './teacher-mark.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'teacher1',
  templateUrl: './teacher-mark.component.html',
  providers: [DataService]
})
export class TeacherMarkComponent implements OnInit {

  public teacher: Teacher;
  public teachers_mark: Teacher[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadTeachers();
  }
  loadTeachers() {
    this.dataService.getTeachers()
      .subscribe((data: Teacher[]) => this.teachers_mark = data);
  }
}

interface Teacher {
  group: any,
  day: Date,
  start: any ,
  finish: any;
  audience: any;
  teacher: any;
  subject: any;
}

