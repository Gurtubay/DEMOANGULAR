import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from './Components/login/login.component';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { RegistroComponent } from './Components/registro/registro.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { AgendaComponent } from './Components/agenda/agenda.component';
import { NewDocComponent } from './Components/new-doc/new-doc.component';
import { DocProcComponent } from './Components/doc-proc/doc-proc.component';
import { DocSignedComponent } from './Components/doc-signed/doc-signed.component';

const routes: Routes = [
  
  {path:'login', component: LoginComponent },
  {path:'dashboard', component: DashboardComponent},
  {path:'agenda', component:AgendaComponent},
  {path: 'nuevo-documento', component:NewDocComponent},
  {path:'documentos-proceso', component:DocProcComponent},
  {path:'documentos-firmados', component:DocSignedComponent},
  {path: 'registro', component: RegistroComponent},
  {path: 'profile', component: ProfileComponent},
  { path:'**', redirectTo:'login', pathMatch:'full' },
  { path:'', redirectTo:'login', pathMatch:'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
