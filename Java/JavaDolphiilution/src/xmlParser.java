
import java.io.*;
import org.w3c.dom.*;
import java.util.Map;
import javax.xml.parsers.*;
import javax.xml.xpath.*;
import org.xml.sax.SAXException;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Anthe
 */
public class xmlParser {
    public void parseXML(String inputxml, Map<Integer, String> choicepath) throws ParserConfigurationException, SAXException, IOException, XPathExpressionException{
        DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
        DocumentBuilder docBuilder = docFactory.newDocumentBuilder();
        Document doc;
        doc = docBuilder.parse(new File(inputxml));

        Node firstChild = doc.getFirstChild();
        XPath xpath = XPathFactory.newInstance().newXPath();
        XPathExpression expr = xpath.compile("//wiidisc/id/options");
        Object o = expr.evaluate(doc, XPathConstants.NODESET);
        NodeList sections = (NodeList) o;
        
        for (int i = 0; i < sections.getLength(); i++) {
            Element e = (Element)sections.item(i);
            String sectionname = e.getAttribute("name");
            System.out.println(sectionname);
            
        }
        
}
    }

