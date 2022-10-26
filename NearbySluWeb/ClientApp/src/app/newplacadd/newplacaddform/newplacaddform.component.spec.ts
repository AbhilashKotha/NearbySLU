import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewplacaddformComponent } from './newplacaddform.component';

describe('NewplacaddformComponent', () => {
  let component: NewplacaddformComponent;
  let fixture: ComponentFixture<NewplacaddformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewplacaddformComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewplacaddformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
