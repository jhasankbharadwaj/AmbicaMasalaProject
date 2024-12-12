import { Routes } from '@angular/router';
import { LoginComponent } from './auth/login/login.component';
import { RegistrationComponent } from './auth/registration/registration.component';

export const routes: Routes = [
    {path:'',component:LoginComponent,pathMatch:'full'},
    {path: 'Login', component:LoginComponent},
    {path:'registration', component:RegistrationComponent},
];
