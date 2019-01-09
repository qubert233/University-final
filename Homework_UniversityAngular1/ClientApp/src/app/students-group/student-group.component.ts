import { Component, OnInit, Inject } from '@angular/core';
import { DataService } from './student-group.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'student1',
  templateUrl: './student-group.component.html',
  providers: [DataService]
})
export class StudentGroupComponent implements OnInit {

  public student: Student;
  public students_group: Student[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadStudents();
  }
  loadStudents() {
    this.dataService.getStudents()
      .subscribe((data: Student[]) => this.students_group = data);
  }
}

interface Student {
  group: any,
  day: Date,
  start: any ,
  finish: any;
  audience: any;
  teacher: any;
  subject: any;
}

