   M S B A M L   `   `   `  ����F  BGestorStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GestorStockGestorStock  5   	       GestorStock.ProductWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GestorStock     5   	   -   5          �Name$  WinProductWindow��5   	    � Title$ Ventana de productos��5   	   $	��550��6&   $	��800��63    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 50��6   ��5   
   �� 5       �� ImageSource$ /fondo4.jpg��6   ._�5   
   �� $ 20��6   $��4q�5       J� Opacity$
 0.75Q�5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #7a2d1d��6#    � Offset$ 0Q�63   � 5      $ #e28743��6#   $
 0.75Q�63   � 5      $ #eab676��6#   $ 1Q�63   5      ��5!      �� 5"      $		 0,1&�6&   $	
 1,0&�67   .��5#      � $ #063970��6#   $ 0Q�63   � 5$      $ #154c79��6#   $
 0.75Q�63   5%      ._�5(      �  � RowDefinitions 5)      �� 5*      $��30 �6$   �� 5+      .+�5.      �  � ColumnDefinitions 5/      �� 50      �� 51      $��25 �6+   �� 52      $��25 �6+   �� 53      $��10 �6+   .+�56      �� $��	Productos��6    
�������$��16(�58       $��Arial Black)�59       $��0��5:       $��Center=�5;       $��30,0,0,0q�5<       �� 5>      -   5         ��Name$ btnMinimizar��5>      $��0q�5?      $��-��5@      
�������$��16(�5B      $��
Montserrat)�5C       � Cursor$
 Hand��5D      $��1��5E      ��5H      �� 5I       �� 
TargetType" ��6$   .�5J   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5K   "   P� 5L   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5M   *   ��  � �� �#c856206G   5N   '   5P      ��5S      �� 5T       �� 
TargetType" ��6.   .R�5U   "   �� $��18��6)   $��18��64   $ 9��5V   )   #��z��5W   )   ._�5X   &   �� $��Center=�67   $��Center=�5Y   7   5Z   #   5[      5^      �� 5`      -   5        $ 	btnCerrar��5`      $��0q�5a      $��X��5b      
�������$��16(�5d      $��
Montserrat)�5e      $
 Hand��5f      $��2��5g      ��5j      �� 5k      " ��6$   .�5l   "   ��  � �� �#c856206?    5m   "   P� 5n   &    �@J�IsMouseOver$
 True��6E   . �5o   *   ��  � �� �#f4a15b6G   5p   '   5r      ��5u      �� 5v      " ��6.   .R�5w   "   �� $��18��6)   $��18��64   $ 9��5x   )   #��z��5y   )   ._�5z   &   �� $��Center=�67   $��Center=�5{   7   5|   #   5}      5�      5�      �� 5�      $��1��6    �� Orientation$ Vertical=�5�      $��10,0,660,380q�5�      .+�5�      �� $��/icono2.jpg��6   $	��100��5�      $	��100��6(   5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ dataGridProductos��5�      $��1��66      AutoGenerateColumns$ False��6C   $��132,10,50,99q�6_      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Producto ID��6-      
IsReadOnly$
 True��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
ProductoId+6a     5�      $ Nombre��6-    6=   �� *Nombre+  5�      $ 
Categoría��6-    6@   �� *Categoria.Nombre+4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      $ 
Habilitado��61    6E   �� *
Habilitado+5�      �� 5�      -   5        $ BtnCerrarWinProductos��5�      $��Cerrar��68   $
��Left=�6I   $��647,447,0,0q�6d   $��1��6y   $	��Top=�6�   $��29��6�   $��80��6�   ���	#FF4065B2���	#FFFAF6F6$��Arial)�6�   $��14(�6�   $
��Bold"�6  6  �� 5�      -   5        $ BtnAgregarProducto��5�      $��Agregar Producto��65   $
��Left=�6P   $��
58,444,0,0q�6k   $��1��6   $	��Top=�6�   $��32��6�   $	��133��6�   ���	#FF4065B2���	#FFFAF6F6$��Arial)�6�   $��14(�6�   $
��Bold"�6  6  �� 5�      -   5        $ BtnEliminarProducto��5�      $��Eliminar Producto��66   $
��Left=�6R   $��454,444,0,0q�6m   $��1��6�   $	��Top=�6�   $��32��6�   $	��145��6�   $��Arial)�6�   $��14(�6�   $
��Bold"�6�   ���	#FF4065B2���	#FFFAF6F66   �� 5�      -   5        $ BtnActualizarProducto��5�      $��Actualizar Producto��68   $
��Left=�6V   $��248,447,0,0q�6q   $��1��6�   $	��Top=�6�   $��29��6�   $	��148��6�   $��Arial)�6�   $��14(�6�   $
��Bold"�6�   ���	#FF4065B2���	#FFFAF6F66$  5�      5�      5�      5�      