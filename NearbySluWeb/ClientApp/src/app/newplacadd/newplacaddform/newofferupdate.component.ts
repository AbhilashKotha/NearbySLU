updateRecord(form: NgForm) {
  this.service.putNewofferData().subscribe(
    res => {
      this.resetForm(form);
      this.service.refreshList();// refreshing the form of the offer function.
      setTimeout(() => { this.isNewofferPosted = false; }, 1000);
    },
    err => { console.log(err); }
  );
}
