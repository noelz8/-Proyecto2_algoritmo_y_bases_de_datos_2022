/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package cosasDeXML;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Text;

/**
 *
 * @author ismae
 */
public class XMLCreador {
    public static void main(String[] args) throws ParserConfigurationException {
        creadorXML();
    }

    private static void creadorXML() throws ParserConfigurationException {
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        DocumentBuilder builder = factory.newDocumentBuilder();
        DOMImplementation implementation = builder.getDOMImplementation();
        
        Document documento = implementation.createDocument(null, "Usuarios", null);
        documento.setXmlVersion("1.0");
        
        Element usuarios = documento.createElement("usuarios");
        Element usuario = documento.createElement("usuario");
        
        Element nombre = documento.createElement("nombre");
        Text textNombre = documento.createTextNode("Insertar variable para ingresar varios nombres");
        nombre.appendChild(textNombre);
        usuario.appendChild(nombre);
        
        Element apellido = documento.createElement("apellido");
        Text textApellido = documento.createTextNode("Insertar varible para ingresar varios apellidos");
        apellido.appendChild(textApellido);
        usuario.appendChild(apellido);
        
        Element edad = documento.createElement("edad");
        Text textEdad = documento.createTextNode("Insertar variable para ingresar varias edades");
        edad.appendChild(textEdad);
        usuario.appendChild(edad);
        
        Element genero = documento.createElement("genero");
        Text textGenero = documento.createTextNode("Insertar variable con generos");
        genero.appendChild(textGenero);
        usuario.appendChild(genero);
        
        Element contraseña = documento.createElement("contraseña");
        Text textContraseña = documento.createTextNode("Ingresar variable con la contraseña");
        contraseña.appendChild(textContraseña);
        usuario.appendChild(contraseña);
        
        Element amigo = documento.createElement("amigo");
        Text textAmigo = documento.createTextNode("Ingresar variable con los amigos");
        amigo.appendChild(textAmigo);
        usuario.appendChild(amigo);
        
        usuarios.appendChild(usuario);
    }
}

