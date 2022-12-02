import { Injectable } from '@angular/core';
import { Component, Inject } from '@angular/core';
import { Newplacadd } from './newplacadd.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class NewplacaddService {

  constructor(private http: HttpClient) { }
 
  formData: Newplacadd = new Newplacadd();
  list: Newplacadd[] = [];
  //list: Newplacadd[];
  readonly baseURL = 'https://localhost:7169/api/addNewPlaces'


  postNewplaceData() {
    return this.http.post(this.baseURL, this.formData);

  }

  putNewplaceData() {
    return this.http.put(`${this.baseURL}/${this.formData.placeId}`, this.formData);
  }

  deleteNewplaceData(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }
  

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res => this.list = res as Newplacadd[]);
  }

  refreshFilteredList(cat:string) {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res => this.list = (res as Newplacadd[]).filter(item => item.category === cat));
  }

}
