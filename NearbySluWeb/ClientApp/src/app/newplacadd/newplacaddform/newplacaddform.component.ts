import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { NewplacaddService } from '../../shared/newplacadd.service';
import { RouterModule } from '@angular/router';
import { error } from '@angular/compiler/src/util';
import { Newplacadd } from '../../shared/newplacadd.model';

@Component({
  selector: 'app-newplacaddform',
  templateUrl: './newplacaddform.component.html',
  styleUrls: ['./newplacaddform.component.css']
})
export class NewplacaddformComponent implements OnInit {

  constructor(public service: NewplacaddService) { }
  isNewPlacePosted = false;
  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {
    if (this.service.formData.placeId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postNewplaceData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isNewPlacePosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putNewplaceData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isNewPlacePosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Newplacadd();
  }
}
