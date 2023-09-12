import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './Components/login/login.component';
import { RegistroComponent } from './Components/registro/registro.component';
import { SidebarComponent } from './Components/sidebar/sidebar.component';

import { SharedModule } from './Components/shared/shared.module';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { HttpClientModule } from '@angular/common/http';

import { Autorizacion } from './Services/Autorizacion.service';
import { Registro } from './Services/Registro.Service';
import { ProfileComponent } from './Components/profile/profile.component';

import { DatePipe } from '@angular/common';
import { SidenavComponent } from './Components/sidenav/sidenav.component';
import { AgendaComponent } from './Components/agenda/agenda.component';
import { NewDocComponent } from './Components/new-doc/new-doc.component';
import { DocProcComponent } from './Components/doc-proc/doc-proc.component';
import { DocSignedComponent } from './Components/doc-signed/doc-signed.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    RegistroComponent,
    ProfileComponent,
    SidenavComponent,
    AgendaComponent,
    NewDocComponent,
    DocProcComponent,
    DocSignedComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    HttpClientModule,
    SidebarComponent
  ],
  providers: [
    Autorizacion,
    Registro,
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
