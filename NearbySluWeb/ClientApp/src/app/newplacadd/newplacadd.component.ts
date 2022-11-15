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
  isNewPlacePosted = false;

  ngOnInit(): void {
    this.service.refreshList();

  }

  populateForm(selectedRecord: Newplacadd) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteNewplaceData(id)
        .subscribe(
          res => {
            this.service.refreshList();
            setTimeout(() => { this.isNewPlacePosted = false; }, 1000);
          },
          err => { console.log(err) }
        )
    }
  }


}
