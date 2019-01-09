import { Component, OnInit, Inject } from '@angular/core';
import { DataService } from './student-mark.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'student2',
  templateUrl: './student-mark.component.html',
  providers: [DataService]
})
export class StudentMarkComponent implements OnInit {

  public student: Student;
  public students_mark: Student[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadStudents();
  }
  loadStudents() {
    this.dataService.getStudents()
      .subscribe((data: Student[]) => this.students_mark = data);
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

