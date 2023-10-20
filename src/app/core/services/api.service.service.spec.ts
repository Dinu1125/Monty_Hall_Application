/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { Api.serviceService } from './api.service';

describe('Service: Api.service', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [Api.serviceService]
    });
  });

  it('should ...', inject([Api.serviceService], (service: Api.serviceService) => {
    expect(service).toBeTruthy();
  }));
});
