import {Component,ViewChild,OnInit } from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import {DatePipe, NgIf} from '@angular/common';
import {MatSidenav, MatSidenavModule} from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon'; // Importa MatIconModule
import { MatListModule } from '@angular/material/list'; // Importa MatListModule
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common'; // Importa CommonModule
import { SharedModule } from '../shared/shared.module';
import { ChartDataset, ChartOptions, ChartType } from 'chart.js'; // Importa ChartDataset, ChartOptions y ChartType


@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
  standalone: true,
  imports: [MatSidenavModule, NgIf, MatButtonModule, SharedModule],
})
export class SidebarComponent implements OnInit {
  @ViewChild('sidenavRef', { static: false }) sidenav!: MatSidenav
  showFiller = false;
  public isExpanded = true;
  public profileHidden=true;

  public pieChartData: ChartDataset[] = [
    {
      data: [300, 500, 100], // Ejemplo de datos
      label: 'Ventas' // Etiqueta opcional para el conjunto de datos
    }
  ];

  public pieChartLabels: string[] = ['Rojo', 'Azul', 'Verde']; // Ejemplo de etiquetas
  public pieChartOptions: ChartOptions = {
    responsive: true
  };
  public pieChartType: ChartType = 'pie'; // Utiliza ChartType en lugar de string


  currentDate!: Date;
  formattedDate: string = '';

  constructor(private datePipe: DatePipe) {}

  ngOnInit(): void {
    this.currentDate = new Date();
    const transformedDate = this.datePipe.transform(this.currentDate, 'dd \'de\' MMMM \'de\' yyyy');
    this.formattedDate = transformedDate !== null ? transformedDate : '';
  }


 public routeLinks = [
  { link: "/dashboard", name: "Dashboard", icon: "../../../assets/img/IconDashboard.png" },
  { link: "/agenda", name: "Agenda", icon: "../../../assets/img/IconAgenda.png" },
  { link: "/nuevo-documento", name: "Nuevo documento", icon: "../../../assets/img/IconNuevoDocumento.png" },
  { link: "/documentos-proceso", name: "Documentos en proceso", icon: "../../../assets/img/IconDocumentosProceso.png" },
  { link: "/documentos-firmados", name: "Documentos firmados", icon: "../../../assets/img/IconDocumentosFirmados.png" }
];

  public toggleMenu() {
    this.isExpanded = !this.isExpanded;
    this.profileHidden=!this.profileHidden;
    this.sidenav.toggle();
  }
}
