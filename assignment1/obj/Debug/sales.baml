   M S B A M L   `   `   `  ����F  Bassignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:assignment1assignment1  5   	       assignment1.sales   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:assignment1     5   	     � Title$  sales��5   	   $	��450��6   $	��800��6$   .��5	      � -   5         �Name$
 name��5	      .+�5
   
   �� -   5         ��Name$ selectedProductsListBox��5
      $
��Left=�63   $	��Top=�6N   $��20,20,20,120q�6f   $	��340��6|   $	��200��6�   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $	��120��6A   ��6$   �� *ProductName+6A   �� 5      $��60��6>   ��6$   �� *
Quantity+6>   5      5      5      �� 5   
   $��Product:��6   $
��Left=�6#   $	��Top=�6>   $��
20,240,0,0q�6V   �� 5   
   -   5         ��Name$ productName��5      $
��Left=�6(   $��27��6C   $��118,239,0,0q�6O   $	��Top=�6d   $	��144��6|   $��16(�6�   .@�5      �� $��Apple��6   �� 5      $��Orange��6   �� 5      $��	Raspberry��6   �� 5      $��	Blueberry��6   �� 5      $��Cauliflower��6   5      �� 5   
   $��Quantity (kg):��6   $
��Left=�6)   $	��Top=�6D   $��
20,280,0,0q�6\   �� 5   
   -   5         ��Name$ quantity��5      $
��Left=�6$   $	��Top=�6?   $��120,280,0,0q�6W   $	��100��6l   �� 5    
   -   5        $	��Add��5       $
��Left=�6   $	��Top=�6:   $��240,280,0,0q�6R   $��80��6g   6r   �� 5"   
   -   5        $��Calculate Total Sales��5"      $
��Left=�61   $	��Top=�6L   $��
20,320,0,0q�6d   $	��150��6x   6�   �� 5$   
   -   5         ��Name$ totalSalesLabel��5$      $��Total Sales: $��6)   $
��Left=�6B   $	��Top=�6]   $��
20,360,0,0q�6u   5%      5&      