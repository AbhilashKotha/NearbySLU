updateRecord(form: NgForm) {
  this.service.putNewofferData().subscribe(
    res => {
      this.resetForm(form);
      this.service.refreshList();
      setTimeout(() => { this.isNewofferPosted = false; }, 1000);
    },
    err => { console.log(err); }
  );
}
