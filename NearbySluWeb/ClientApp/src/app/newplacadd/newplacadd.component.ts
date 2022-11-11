import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Newplacadd } from '../shared/newplacadd.model';
import { NewplacaddService } from '../shared/newplacadd.service';

@Component({
  selector: 'app-newplacadd',
  templateUrl: './newplacadd.component.html',
  styleUrls: ['./newplacadd.component.css']
})
export class NewplacaddComponent implements OnInit {

  constructor(public service: NewplacaddService) { }
  

  ngOnInit(): void {
    this.service.refreshList();

  }

  populateForm(selectedRecord: Newplacadd) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

 


}
