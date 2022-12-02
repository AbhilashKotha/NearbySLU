import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { StoreOffersaddService } from '../../shared/storeoffersadd.service';
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
  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {
    if (this.service.formData.offerId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postStoreoffersData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isStoreOffersPosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putStoreOffersData().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        setTimeout(() => { this.isStoreOffersPosted = false; }, 1000);
      },
      err => { console.log(err); }
    );
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Storeoffersadd();
  }
}
