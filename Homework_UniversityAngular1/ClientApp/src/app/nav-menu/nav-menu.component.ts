import { Component } from '@angular/core';
import { User } from '../_models';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  showLogin() {
    if (sessionStorage.getItem('currentUser')) {
      return true;
    }
    else {
      return false;
    }
  }

  getUser() {
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    return obj.username;
  }

  getRole() {
    let obj: User = JSON.parse(sessionStorage.getItem('currentUser'));
    return obj.role;
  }
}


