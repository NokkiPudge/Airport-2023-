   M S B A M L   `   `   `  ����B  >AIRPORT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AIRPORT.ViewsAIRPORT.Views  5          AIRPORT.Views.FlightUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AIRPORT.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��10 20q�6    � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6#   $��48��60   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      �� $��ViewRegistration��6   $��24(�60   $��0��6?   6Q   �� 5      -   5         ��Name$ 	ButtonDel��5   �   $��Delete��6   $��0��6B   $��3��6O   $��Center=�6_   $��46��6|   $��10 0 0 0q�6�   6�   5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataFlighList��5         AutoGenerateColumns .     
IsReadOnly . $��5 0 5 0q�6\      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        GridDate��,  &System.Windows.Controls.DataGridColumn   Header$
 Date��5   ;      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6r   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6I   �� *Flight.DepartureDate+6     5      -   5        GridName��$
 Name��5   ;   $
 auto 6p   	 . 
 6I   �� *Passenger.Fullname+6}     5      -   5        	GridPhone��$ Phone��5   <   $
 auto 6o   	 . 
 6K   �� *Passenger.phone+6|     5      -   5        GridTicketNumber��$ TicketNumber��5   C   $
 auto 6z   	 . 
 6Y   �� *TicketNumber+6�     5      -   5        
GridFlight��$ Flight��5   =   $ * 6s   	 . 
 6M   �� *Flight.NameFlight+6}   5!      5"      5#      5$      