import { Component } from '@angular/core';
import { Newplacadd } from '../shared/newplacadd.model';
import { NewplacaddService } from '../shared/newplacadd.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(public service: NewplacaddService) { }
  public show: boolean = false;
  ngOnInit(): void {
    this.service.refreshList();

  }

  removeFilters() {
    this.service.refreshList();
    this.show = false;
  }
  onCatClick(cat:string) {
    this.service.refreshFilteredList(cat.toString());
    this.show = true;
  }
}
