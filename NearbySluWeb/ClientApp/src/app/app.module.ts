import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { NewplacaddComponent } from './newplacadd/newplacadd.component';
import { NewplacaddformComponent } from './newplacadd/newplacaddform/newplacaddform.component';
import { StoreoffersaddComponent } from './storeoffersadd/storeoffersadd.component';
import { StoreoffersaddformComponent } from './storeoffersadd/storeoffersaddform/storeoffersaddform.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
   /* FormsModule,*/
    NewplacaddComponent,
    NewplacaddformComponent,
    StoreoffersaddComponent,
    StoreoffersaddformComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
      //{ path: 'add-new-place', component: NewplacaddComponent, canActivate: [AuthorizeGuard] },
      { path: 'add-new-place', component: NewplacaddComponent },
      { path: 'StoreOffers', component: StoreoffersaddComponent },
    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
