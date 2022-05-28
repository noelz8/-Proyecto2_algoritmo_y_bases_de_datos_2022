/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package cosasDeXML;

import java.io.File;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Text;

/**
 *
 * @author ismae
 */
public class XMLCreador {
    public static void main(String[] args) throws ParserConfigurationException, TransformerException {
        try {
            // TODO code application logic here
            
            DocumentBuilderFactory factory  = DocumentBuilderFactory.newInstance();
            DocumentBuilder  builder = factory.newDocumentBuilder();
            DOMImplementation implementation = builder.getDOMImplementation();
            
            Document documento = implementation.createDocument(null, "MyMusic", null);
            documento.setXmlVersion("1.0");
            
            //Estos son los "tags" del XML 
            
            Element personas = documento.createElement("personas");
            Element persona = documento.createElement("persona");
            
            Element nombre = documento.createElement("nombres");
            Text textNombre = documento.createTextNode("Ismael");
            nombre.appendChild(textNombre);
            persona.appendChild(nombre);
            
            Element apellido = documento.createElement("apellido");
            Text textApellido = documento.createTextNode("Mena");
            apellido.appendChild(textApellido);
            persona.appendChild(apellido);
            
            Element edad = documento.createElement("edad");
            Text textEdad = documento.createTextNode("20");
            edad.appendChild(textEdad);
            persona.appendChild(edad);
            
            Element genero = documento.createElement("genero");
            Text textGenero = documento.createTextNode("rock");
            genero.appendChild(textGenero);
            persona.appendChild(genero);            
            
            Element amigo = documento.createElement("amigo");
            Text textAmigo = documento.createTextNode("Noel");
            amigo.appendChild(textAmigo);
            persona.appendChild(amigo);
            
            Element contraseña = documento.createElement("contraseña");
            Text textContraseña = documento.createTextNode("password");
            contraseña.appendChild(textContraseña);
            persona.appendChild(contraseña);
            
            personas.appendChild(persona);
            
            documento.getDocumentElement().appendChild(personas);
            
            Source source = new DOMSource(documento);
            Result result = new StreamResult(new File("MyMusic.xml"));
            
            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            transformer.transform(source, result);
            
        } catch (ParserConfigurationException | TransformerConfigurationException ex) {
            Logger.getLogger(XMLCreador.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex.getMessage());
        }
        
        
        
    }

}

