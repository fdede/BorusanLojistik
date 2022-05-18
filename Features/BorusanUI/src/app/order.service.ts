import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SearchResult } from './SearchResult';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private apiUrl: string;

  constructor(private http: HttpClient) {
    this.apiUrl = "https://localhost:7150/api/orders/GetAllOrdersWithStatus";
   }

   getData(): Observable<SearchResult> {
    return this.http.get<SearchResult>(this.apiUrl);
  }

}
