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
  readonly baseURL = 'https://localhost:7169/api/storeoffersadd'


  postStoreoffersData() {
    return this.http.post(this.baseURL, this.formData);

  }

  putStoreoffersData() {
    return this.http.put(`${this.baseURL}/${this.formData.offerId}`, this.formData);
  }

  deleteStoreoffersData(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }
 

  

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res => this.list = res as Storeoffersadd[]);
  }

  //constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  //  http.get<Newplacadd[]>(baseUrl + 'addNewPlaces').subscribe(result => {
  //   this.places = result;
  //  }, error => console.error(error));

    

  //  }


  //constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { }

    //PutaddNewPlace() {
    //  return this.http.post(this.baseURL, this.formData);
    //}
    //putPaymentDetail() {
    //  return this.http.put(`${this.baseURL}/${this.formData.placeId}`, this.formData);
    //}
    //deletePaymentDetail(id: number) {
    //  return this.http.delete(`${this.baseURL}/${id}`);
    //}
  

  //refreshList() {
  //  this.http.get(this.baseURL)
  //    .toPromise()
  //    .then(res => this.list = res as Newplacadd[]);
  /*}*/
}