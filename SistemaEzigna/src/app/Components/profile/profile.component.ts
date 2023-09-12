import { Component, OnInit } from '@angular/core';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  currentDate!: Date;
  formattedDate: string = '';

  constructor(private datePipe: DatePipe) {}

  ngOnInit(): void {
    this.currentDate = new Date();
    const transformedDate = this.datePipe.transform(this.currentDate, 'dd \'de\' MMMM \'de\' yyyy');
    this.formattedDate = transformedDate !== null ? transformedDate : '';
  }
}
