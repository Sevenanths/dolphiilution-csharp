
import java.io.*;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.*;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.xpath.XPathExpressionException;
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
public class dolphinMain extends javax.swing.JFrame {

    /**
     * Creates new form dolphinMain
     */
    public static String gamesPath;
    public static String riivoPath;
    public Map<Integer, String> choicePath = new HashMap<Integer, String>();
    public dolphinMain() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jGamesList = new javax.swing.JList();
        jPatchPanel = new javax.swing.JPanel();
        jXMLList = new javax.swing.JComboBox();
        jScrollPane2 = new javax.swing.JScrollPane();
        jRiivolutionList = new javax.swing.JList();
        jPatchList = new javax.swing.JComboBox();
        jPatchBox = new javax.swing.JTextField();
        jPatchButton = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();
        jMenuBar = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jLoadRiivolution = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jScrollPane1.setViewportView(jGamesList);

        jPatchPanel.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(204, 204, 204)));

        jXMLList.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jXMLListActionPerformed(evt);
            }
        });

        jScrollPane2.setViewportView(jRiivolutionList);

        jPatchList.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jPatchBox.setText("jTextField1");

        jPatchButton.setText("jButton1");

        jButton1.setLabel("Load");
        jButton1.setPreferredSize(new java.awt.Dimension(73, 22));
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPatchPanelLayout = new javax.swing.GroupLayout(jPatchPanel);
        jPatchPanel.setLayout(jPatchPanelLayout);
        jPatchPanelLayout.setHorizontalGroup(
            jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPatchPanelLayout.createSequentialGroup()
                .addGap(5, 5, 5)
                .addGroup(jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPatchButton, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jPatchPanelLayout.createSequentialGroup()
                        .addGroup(jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPatchPanelLayout.createSequentialGroup()
                                .addComponent(jPatchList, 0, 99, Short.MAX_VALUE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jPatchBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPatchPanelLayout.createSequentialGroup()
                                .addComponent(jXMLList, javax.swing.GroupLayout.PREFERRED_SIZE, 114, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPatchPanelLayout.setVerticalGroup(
            jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPatchPanelLayout.createSequentialGroup()
                .addGap(4, 4, 4)
                .addGroup(jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jXMLList, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 219, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPatchPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jPatchList, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jPatchBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPatchButton, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jMenu1.setText("Load Wii Games folder");
        jMenu1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jMenu1MouseClicked(evt);
            }
        });
        jMenuBar.add(jMenu1);

        jLoadRiivolution.setText("Load Riivolution Folder");
        jLoadRiivolution.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jLoadRiivolutionMouseClicked(evt);
            }
        });
        jMenuBar.add(jLoadRiivolution);

        setJMenuBar(jMenuBar);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 147, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPatchPanel, javax.swing.GroupLayout.PREFERRED_SIZE, 177, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(339, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jPatchPanel, javax.swing.GroupLayout.PREFERRED_SIZE, 324, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addGap(18, 18, 18))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jMenu1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenu1MouseClicked
        JFileChooser browseForGames = new JFileChooser();
        browseForGames.setDialogTitle("Select your games folder.");
        browseForGames.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);

        
        if (browseForGames.showOpenDialog(this) == JFileChooser.APPROVE_OPTION){
            gamesPath = browseForGames.getSelectedFile().toString();
            jGamesList.setListData(new Object[0]);
           
            
            File[] fileList = new File((gamesPath)).listFiles();

            
            DefaultListModel listModel = new DefaultListModel();
            for (File file : fileList){
                listModel.addElement(file.getName());
            }
            jGamesList.setModel(listModel);
        }
        
    }//GEN-LAST:event_jMenu1MouseClicked

    private void jLoadRiivolutionMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jLoadRiivolutionMouseClicked
        JFileChooser browseForRiivo = new JFileChooser();
        browseForRiivo.setDialogTitle("Select your games folder.");
        browseForRiivo.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        
        if (browseForRiivo.showOpenDialog(this) == JFileChooser.APPROVE_OPTION){
        riivoPath = browseForRiivo.getSelectedFile().toString() + "/riivolution";
        File[] fileList = new File((riivoPath)).listFiles();
        
        DefaultComboBoxModel model = new DefaultComboBoxModel();
        for (File file : fileList){
            if (file.getAbsolutePath().contains(".xml")){
                model.addElement(file.getName());
            }
        }
        jXMLList.setModel(model);
        
        }
    }//GEN-LAST:event_jLoadRiivolutionMouseClicked

    private void jXMLListActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jXMLListActionPerformed
   
    }//GEN-LAST:event_jXMLListActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
  xmlParser parser = new xmlParser();
        try {
            parser.parseXML(riivoPath + "/riivolution/" + jXMLList.getSelectedItem().toString() + ".xml", choicePath);
        }
        catch(Exception ex){}        // TODO add your handling code here:
    }//GEN-LAST:event_jButton1ActionPerformed
public static void infoBox(String infoMessage, String location)
    {
        JOptionPane.showMessageDialog(null, infoMessage, "InfoBox: " + location, JOptionPane.INFORMATION_MESSAGE);
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
             /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        
        //</editor-fold>
 try {
        UIManager.setLookAndFeel(
            UIManager.getSystemLookAndFeelClassName());
    } catch (Exception e) { }
        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new dolphinMain().setVisible(true);
                
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JList jGamesList;
    private javax.swing.JMenu jLoadRiivolution;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar;
    private javax.swing.JTextField jPatchBox;
    private javax.swing.JButton jPatchButton;
    private javax.swing.JComboBox jPatchList;
    private javax.swing.JPanel jPatchPanel;
    private javax.swing.JList jRiivolutionList;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JComboBox jXMLList;
    // End of variables declaration//GEN-END:variables
}
