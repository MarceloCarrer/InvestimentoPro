/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AtivosComponent } from './ativos.component';

describe('AtivosComponent', () => {
  let component: AtivosComponent;
  let fixture: ComponentFixture<AtivosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AtivosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AtivosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
