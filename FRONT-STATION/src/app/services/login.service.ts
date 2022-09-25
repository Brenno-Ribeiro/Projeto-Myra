import { Injectable } from '@angular/core';
import{ HttpClient } from '@angular/common/http'
import { API_PATH } from 'src/environments/environment';
import { IStatusCode } from '../interfaces/IStatusCode';
import { Auth } from '../class/Auth';

@Injectable({
  providedIn: 'root'
})

export class LoginService {

  constructor(private httpclient: HttpClient) { }

  SingUp(auth: Auth){
      return this.httpclient.post<IStatusCode>(`${API_PATH}login`,auth).toPromise()
  }
}
