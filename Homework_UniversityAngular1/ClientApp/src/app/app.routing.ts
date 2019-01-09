import { Routes, RouterModule } from '@angular/router';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AdminManageComponent } from './admin-manage/admin-manage.component';
import { TeacherSheduleComponent } from './teachers-shedule/teacher-shedule.component';
import { TeacherMarkComponent } from './teachers-mark/teacher-mark.component';
import { SpecialityComponent } from './speciality/speciality.component';
import { StudentSheduleComponent } from './students-shedule/student-shedule.component';
import { StudentGroupComponent } from './students-group/student-group.component';
import { StudentMarkComponent } from './students-mark/student-mark.component';

import { LoginComponent } from './login/index';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/index';

const appRoutes: Routes = [
    { path: 'login', component: LoginComponent },
  { path: '', component: HomeComponent, canActivate: [AuthGuard] },
  { path: 'adminmanage', component: AdminManageComponent, canActivate: [AuthGuard] },
  { path: 'teachershedule', component: TeacherSheduleComponent, canActivate: [AuthGuard] },
  { path: 'teachermark', component: TeacherMarkComponent, canActivate: [AuthGuard] },
  { path: 'speciality', component: SpecialityComponent, canActivate: [AuthGuard] },
  { path: 'studentshedule', component: StudentSheduleComponent, canActivate: [AuthGuard] },
  { path: 'studentgroup', component: StudentGroupComponent, canActivate: [AuthGuard] },
  { path: 'studentmark', component: StudentMarkComponent, canActivate: [AuthGuard] },

  { path: 'counter', component: CounterComponent, canActivate: [AuthGuard] },
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthGuard] },

    // otherwise redirect to home
    { path: '**', redirectTo: 'login' }
];

export const routing = RouterModule.forRoot(appRoutes);
