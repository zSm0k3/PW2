import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CursoService {

  private baseUrl = 'https://localhost:7094/curso';

  constructor(private http: HttpClient) { }

  listar() : Observable<any> {
    return this.http.get(`${this.baseUrl}/listar`);
  }

  adicionar(curso: any) : Observable<any> {
    return this.http.post
       (`${this.baseUrl}/adicionar`, curso);
  }

  atualizar(curso: any) : Observable<any> {
    return this.http.put
      (`${this.baseUrl}/atualizar`, curso);
  }

  remover(id: number) : Observable<any> {
    return this.http.delete
      (`${this.baseUrl}/remover/${id}`)
  }

}
