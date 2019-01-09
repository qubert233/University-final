import { Component, OnInit, Inject } from '@angular/core';
import { DataService } from './teacher-shedule.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'teacher',
  templateUrl: './teacher-shedule.component.html',
  providers: [DataService]
})
export class TeacherSheduleComponent implements OnInit {

  public teacher: Teacher;
  public teachers_shedule: Teacher[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadTeachers();
  }
  loadTeachers() {
    this.dataService.getTeachers()
      .subscribe((data: Teacher[]) => this.teachers_shedule = data);
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

