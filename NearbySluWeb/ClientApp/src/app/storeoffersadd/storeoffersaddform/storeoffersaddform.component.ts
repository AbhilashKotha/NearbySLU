import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { StoreoffersaddService } from '../../shared/storeoffersadd.service';
import { RouterModule } from '@angular/router';
import { error } from '@angular/compiler/src/util';
import { Storeoffersadd } from '../../shared/storeoffersadd.model';

@Component({
  selector: 'app-storeoffersaddform',
  templateUrl: './storeoffersaddform.component.html',
  styleUrls: ['./storeoffersaddform.component.css']
})
export class StoreoffersaddformComponent implements OnInit {

  constructor(public service:StoreoffersaddService) { }
  isNewPlacePosted = false;
  isNewOfferPosted = false;
  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {
    if (this.service.formData.offerId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }
// added insert method
  insertRecord(form: NgForm) {
    this.service.postStoreoffersData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isNewOfferPosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }
// added update records from the data base
  updateRecord(form: NgForm) {
    this.service.putStoreoffersData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isNewOfferPosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }

  // removed unwanted delete code method

// added reset form to the database
  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Storeoffersadd();
  }
}
