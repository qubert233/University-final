import { Component, OnInit, Inject } from '@angular/core';
import { DataService } from './student-shedule.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'student',
  templateUrl: './student-shedule.component.html',
  providers: [DataService]
})
export class StudentSheduleComponent implements OnInit {

  public student: Student;
  public students: Student[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadStudents();
  }
  loadStudents() {
    this.dataService.getStudents()
      .subscribe((data: Student[]) => this.students = data);
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

