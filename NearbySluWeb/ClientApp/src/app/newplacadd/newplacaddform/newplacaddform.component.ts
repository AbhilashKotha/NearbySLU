import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { NewplacaddService } from '../../shared/newplacadd.service';
import { RouterModule } from '@angular/router';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-newplacaddform',
  templateUrl: './newplacaddform.component.html',
  styleUrls: ['./newplacaddform.component.css']
})
export class NewplacaddformComponent implements OnInit {

  constructor(public service: NewplacaddService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {
    this.service.postNewplaceData().subscribe(
      res => { },
      err => { console.log(err) }
    );
  }
}
