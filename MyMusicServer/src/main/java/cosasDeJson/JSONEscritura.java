/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package cosasDeJson;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

/**
 *
 * @author ismae
 */
public class JSONEscritura {
    public static void main(String[] args) {
        crearJSON();
        
    }

    private static void crearJSON() {
        /**
         * 
         * Esta funcion crea el archivo de formato JSON utilizando JSONObjects y JSONArray 
         */
        
        JSONObject cancion = new JSONObject();
        //cancion.put("cancion","Se pone una cancion con alguna funcion");
        
        JSONArray canciones = new JSONArray();
        canciones.add(cancion);
        
        //Acá va un for o while para ingresar varios datos de distintos usuarios
        JSONObject nombre = new JSONObject();
        nombre.put("nombre","Acá viene una variable para que ingrese todos los datos");
        JSONObject apellido = new JSONObject();
        apellido.put("apellido", "Acá viene variable igual que la del nombre");
        JSONObject edad = new JSONObject();
        edad.put("edad", "Acá va int como variable para igresar todos los datos");
        //Acá va un for o un while para crear varios JSONObjects, para los varios generos asignados a los usuarios
        JSONObject genero = new JSONObject();
        genero.put("genero", "rock,etc...(como variable para ingresar varios datos");
        JSONArray generos = new JSONArray();
        //Acá va un for o while para ingresar varios datos al JSONArray
        generos.add(genero);
        JSONObject contraseña = new JSONObject();
        contraseña.put("contraseña", "Variable para contraseña");
        //Acá va un for o un while para crear más amigos 
        JSONObject amigo = new JSONObject();
        amigo.put("amigo", "Nombre del amigo a modo de variable");
        //Acá va un for o un while para ingresar la lista de amigos
        JSONArray amigos = new JSONArray();
        amigos.add(amigos);
        
        
    }   
}
