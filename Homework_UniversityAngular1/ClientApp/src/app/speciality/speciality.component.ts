import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { DataService } from './speciality.service';
import { Speciality } from './speciality';
import { User } from '../_models';

@Component({
  selector: 'speciality',
  templateUrl: './speciality.component.html',
  providers: [DataService]
})
export class SpecialityComponent implements OnInit {

  public speciality: Speciality;
  public specialities: Speciality[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadSpecialities();
  }
  loadSpecialities() {
    this.dataService.getSpecialities()
      .subscribe((data: Speciality[]) => this.specialities = data);
  }
}

