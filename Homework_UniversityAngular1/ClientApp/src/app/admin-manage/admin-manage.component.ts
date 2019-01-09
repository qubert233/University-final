import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { DataService } from './admin-manage.service';


@Component({
  selector: 'admin',
  templateUrl: './admin-manage.component.html',
  providers: [DataService]
})
export class AdminManageComponent implements OnInit {

  public admin: Admin;
  public admin_manage: Admin[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadAdmins();
  }
  loadAdmins() {
    this.dataService.getAdmins()
      .subscribe((data: Admin[]) => this.admin_manage = data);
  }
}

interface Admin {
    id: any,
    firstname: string,
    middlename: string,
    lastname: string,
    department?: string
}
