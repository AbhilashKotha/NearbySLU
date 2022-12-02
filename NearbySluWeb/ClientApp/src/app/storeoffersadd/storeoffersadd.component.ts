import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Storeoffersadd } from '../shared/storeoffersadd.model';
import { StoreoffersaddService } from '../shared/storeoffersadd.service';

@Component({
  selector: 'app-storeoffersadd',
  templateUrl: './storeoffersadd.component.html',
  styleUrls: ['./storeoffersadd.component.css']
})
export class StoreoffersaddComponent implements OnInit {

  constructor(public service: StoreoffersaddService) { }
  isStoreOffersPosted = false;

  ngOnInit(): void {
    this.service.refreshList();

  }

  populateForm(selectedRecord: Storeoffersadd) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Are you sure to delete this offer?')) {
      this.service.deleteStoreoffersData(id)
        .subscribe(
          res => {
            this.service.refreshList();
            setTimeout(() => { this.isStoreOffersPosted = false; }, 1000);
          },
          err => { console.log(err) }
        )
    }
  }


}
