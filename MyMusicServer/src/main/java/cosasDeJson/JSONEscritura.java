/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package cosasDeJson;

import java.io.FileWriter;
import java.io.IOException;
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
        // Se crean los generos
        JSONObject generoRock = new JSONObject();
        generoRock.put("genero","rock");
        JSONObject generoJazz = new JSONObject();
        generoJazz.put("genero","jazz");
        JSONObject generoBlues = new JSONObject();
        generoBlues.put("genero","blues");
        //Los generos se agregan a una lista la cual los almacena como un arreglo de datos tipo JSON 
        JSONArray generoList1 = new JSONArray();
        generoList1.add(generoBlues);
        generoList1.add(generoRock);
        generoList1.add(generoJazz);
        //Se crean los amigos
        JSONObject amigo1 = new JSONObject();
        amigo1.put("amigo1", "Noel");
        JSONObject amigo2 = new JSONObject();
        amigo2.put("amigo2","Christopher");
        //Se agregan los datos de los amigos a una lista la cual los almacena como un arreglo de datos tipo JSON
        JSONArray amigos = new JSONArray();
        amigos.add(amigo1);
        amigos.add(amigo2);
        //Se crean los datos de la persona1
        JSONObject persona1 = new JSONObject();
        persona1.put("nombre", "Ismael");
        persona1.put("apellido","Mena");
        persona1.put("edad", 20);
        persona1.put("genero",generoList1);
        persona1.put("contraseña", "password");
        persona1.put("amigos",amigos);
        //Se crean otros generos musicales
        JSONObject generoReggae = new JSONObject();
        generoReggae.put("genero","reggae");
        JSONObject generoSKA = new JSONObject();
        generoSKA.put("genero","SKA");
        JSONObject generoTecno = new JSONObject();
        generoTecno.put("genero","tecno");
        //Se almacenan dentro de un arreglo de datos tipo JSON
        JSONArray generoList2 = new JSONArray();
        generoList2.add(generoBlues);
        generoList2.add(generoRock);
        generoList2.add(generoJazz);
        //Se crean los amigos de la segunda persona
        JSONObject amigo3 = new JSONObject();
        amigo1.put("amigo1", "Ismael");
        JSONObject amigo4 = new JSONObject();
        amigo2.put("amigo2","Noel");
        //Se almacenan en un arreglo de datos tipo JSON
        JSONArray amigos2 = new JSONArray();
        amigos2.add(amigo3);
        amigos2.add(amigo4);
        //Se crea la segunda persona
        JSONObject persona2 = new JSONObject();
        persona2.put("nombre", "Christopher");
        persona2.put("apellido","Blanco");
        persona2.put("edad", 19);
        persona2.put("genero",generoList2);
        persona2.put("contraseña", "password");
        persona2.put("amigos",amigos2);
        //Se almacenan las personas en espacios separados para mejor legibilidad
        JSONObject datosP1 = new JSONObject();
        datosP1.put("datos", persona1);
        JSONObject datosP2 = new JSONObject();
        datosP2.put("datos", persona2);
        //Se almacenan los espacios en un arreglo para que sea este el que se imprima en el documento
        JSONArray listaPersonas = new JSONArray();
        listaPersonas.add(datosP1);
        listaPersonas.add(datosP2);
        
        try(FileWriter file = new FileWriter("personas.json")){
             file.write(listaPersonas.toJSONString());
             file.flush();
        }catch(IOException io){
            io.printStackTrace();
        }
        
    }
}
