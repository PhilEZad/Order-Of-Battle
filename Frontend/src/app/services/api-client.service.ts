import { Injectable } from '@angular/core';
import axios, { Axios } from "axios";


export const customAxious = axios.create({
  baseURL: ''
})

@Injectable({
  providedIn: 'root'
})



export class ApiClientService {

  constructor() { }
}
