import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { fakeBackendProvider } from './_helpers/index';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AdminManageComponent } from './admin-manage/admin-manage.component';
import { TeacherSheduleComponent } from './teachers-shedule/teacher-shedule.component';
import { TeacherMarkComponent } from './teachers-mark/teacher-mark.component';


import { SpecialityComponent } from './speciality/speciality.component';
import { StudentSheduleComponent } from './students-shedule/student-shedule.component';
import { StudentGroupComponent } from './students-group/student-group.component';
import { StudentMarkComponent } from './students-mark/student-mark.component';

import { AuthGuard } from './_guards/index';
import { JwtInterceptor } from './_helpers/index';
import { AuthenticationService, UserService } from './_services/index';
import { LoginComponent } from './login/index';
import { routing } from './app.routing';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    FooterComponent,
    CounterComponent,
    FetchDataComponent,
    AdminManageComponent,
    TeacherSheduleComponent,
    TeacherMarkComponent,
    SpecialityComponent,
    StudentSheduleComponent,
    StudentGroupComponent,
    StudentMarkComponent,
    LoginComponent,
    HomeComponent
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    routing
    //RouterModule.forRoot([
    //  { path: '', component: HomeComponent, pathMatch: 'full' },
    //  { path: 'counter', component: CounterComponent },
    //  { path: 'fetch-data', component: FetchDataComponent },
    //  { path: 'teacher', component: TeacherComponent },
    //  { path: 'speciality', component: SpecialityComponent },
    //  { path: 'student', component: StudentComponent }

    //])
  ],
  providers: [AuthGuard,
    AuthenticationService,
    UserService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: JwtInterceptor,
      multi: true
    },

    // providers used to create fake backend
   // fakeBackendProvider
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
