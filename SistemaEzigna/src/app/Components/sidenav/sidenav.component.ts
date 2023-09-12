import { Component, Input, Output, EventEmitter } from "@angular/core";


@Component({
  selector: 'sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],

})
export class SidenavComponent {


  @Input() isExpanded: boolean;
  @Output() toggleMenu = new EventEmitter();
  constructor(){
    this.isExpanded=false;
  }
  public routeLinks = [
    { link: "app-dashboard", name: "Dashboard", icon: "dashboard" },
    // { link: "locations", name: "Locations", icon: "account_balance" },
  ];
}