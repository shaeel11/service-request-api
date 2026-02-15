import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ServiceRequest } from '../models/service-request';

@Injectable({
  providedIn: 'root'
})
export class ServiceRequestService {
  private apiUrl = 'http://localhost:5119/api/servicerequests';

  constructor(private http: HttpClient) {}

  getAll(): Observable<ServiceRequest[]> {
    return this.http.get<ServiceRequest[]>(this.apiUrl);
  }

  create(request: ServiceRequest): Observable<ServiceRequest> {
    return this.http.post<ServiceRequest>(this.apiUrl, request);
  }
}
