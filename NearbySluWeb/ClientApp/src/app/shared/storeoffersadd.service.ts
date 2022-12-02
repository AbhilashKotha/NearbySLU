import { Injectable } from '@angular/core';
import { Component, Inject } from '@angular/core';
import { Storeoffersadd } from './storeoffersadd.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class StoreoffersaddService {

  constructor(private http: HttpClient) { }
 
  formData: Storeoffersadd = new Storeoffersadd();
  list: Storeoffersadd[] = [];
  //list: Newplacadd[];
  readonly baseURL = 'https://localhost:7169/api/storeOffersAdd'

// added post method
  postStoreoffersData() {
    return this.http.post(this.baseURL, this.formData);

  }
// add put method
  putStoreoffersData() {
    return this.http.put(`${this.baseURL}/${this.formData.offerId}`, this.formData);
  }
// added delete method
  deleteStoreoffersData(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }
 

  

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res => this.list = res as Storeoffersadd[]);
  }

  // removed unwanted code
}
