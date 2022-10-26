import { Injectable } from '@angular/core';
import { Newplacadd } from './newplacadd.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class NewplacaddService {
  
  formData: Newplacadd = new Newplacadd();
  readonly baseURL = 'http://localhost:61236/api/PaymentDetail';
/*  list: Newplacadd[];*/


  constructor(private http: HttpClient) { }

  postPaymentDetail() {
    return this.http.post(this.baseURL, this.formData);
  }
  putPaymentDetail() {
    return this.http.put(`${this.baseURL}/${this.formData.placeId}`, this.formData);
  }
  deletePaymentDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  //refreshList() {
  //  this.http.get(this.baseURL)
  //    .toPromise()
  //    .then(res => this.list = res as Newplacadd[]);
  /*}*/
}
