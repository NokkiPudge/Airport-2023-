   M S B A M L   `   `   `  ����B  >AIRPORT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AIRPORTAIRPORT  5   	   -clr-namespace:AIRPORT.ViewsAIRPORT.Views  5   	       AIRPORT.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:AIRPORT     5   	   -viewsclr-namespace:AIRPORT.Views     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   6.   �� 5      6!   .+�5   
   o� $��25��6   $	��Top=�6   $��0,0,10,0q�63   .@�5      m� $
��Info��6   .@�5      m� $��About��6   6,   5      m� 5      $��Settings��6   .@�5      m� $��Visual��6   6-   5      5      �� 5   
   $	��120��6   $��10,25,20,15q�6   
�������
�������$��1q�6_   �� 5   
   -   5         ��Name$ FlightButton��5   ,   $��0��6B   $��0��6R   $��РегистрЛист��6_   $��30��6u   $	��100��6�   $	��Top=�6�   $��
20,44,30,0q�6�   6�   �� 5   
   -   5        $ 	RegButton��5   )   $��0��6<   $��Регистрация��6L   $��30��6b   $	��100��6n   $	��Top=�6z   $��20,110,30,0q�6�   �� 5   
   -   5        $ ReportButton��5   )   $��0��6?   $��0��6O   $��Меню репортов��6\   $��30��6t   $	��100��6�   $	��Top=�6�   $��20,174,30,0q�6�   6�   � 5   
   $��1��6   .+�5      �� -   5         ��Name$ UserControls��5      $��1��63   5"      5#      5$      