import { Inject, Injectable, InjectionToken } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export const API_URL = new InjectionToken<string>('API_URL');

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private httpClient: HttpClient, @Inject(API_URL) private baseUrl: string) {}

  get(data: any) {
    return this.httpClient.post(`${this.baseUrl}api/MontyHall/simulate`, data);
  }
}
