   M S B A M L   `   `   `  ����C  ?Tamalito, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TamalitoTamalito  5   	        Tamalito.AniadirInventario   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tamalito     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  AñadirInventario��5   	   $	��415��6"   $	��420��6/    � WindowStyle$
 None=�6;    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6h   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      
������ ._�5      � ���	#FF455A64.+�5      �� -   5        $
��Left=�5      $��32��64   $��32��6?   $��9 0 0 0q�6K   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6\   $��0q�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�6.   5      �� 5      $��Center=�6   $��Center=�65   $��18(�6P   ���	#DDFFFFFF$
��Bold"�6u   $��Segoe UI)�6�   .��6�   Añadir inventario6�   �� 5      -   5        $��Right=�5      $��32��65   $��32��6@   $��0 0 9 0q�6L   $ Depth3=�6]   $��0q�6�   .��5        $ WindowClose=�6.   5      5       5!      � 5#   
   $��1��6   .+�5$      �� -   5         ��Name$ lbIdProducto��5$      $��Id Producto��6*   $
��Left=�6@   $��	37,28,0,0q�6[   $	��Top=�6n   $��26��6�   $��99��6�   ���	#FF373E4F$
��Bold"�6�   $��16(�6�   �� 5%      -   5        $ lbNombre��5%      $��Nombre��6&   $
��Left=�67   $��	37,73,0,0q�6R   $	��Top=�6e   $��87��6}   $��26��6�   $
��Bold"�6�   ���	#FF3C414C$��16(�6�   �� 5&      -   5         ��Name$ tbIdProducto��5&      $
��Left=�6,   $��35��6G   $��
189,19,0,0q�6S   	 �� TextWrapping$
	 Wrap=�6g   $	��Top=�6{   $	��160��6�   $��16(�6�   �� 5'      -   5        $ tbNombre��5'      $
��Left=�6(   $��32��6C   $��
189,67,0,0q�6O   $
	 Wrap=�6c   $	��Top=�6w   $	��160��6�   $��16(�6�   �� 5(      -   5        $ lbNuevoInventario��5(      $��Agregar��6/   $
��Left=�6A   $��
37,251,0,0q�6\   $	��Top=�6p   $	��143��6�   $��26��6�   $
��Bold"�6�   ���	#FF23262E$��16(�6�   �� 5)      -	   5        $ tbNuevoInventario��5)      $
��Left=�61   $��40��6L   $��197,243,0,0q�6X   $
	 Wrap=�6m   $	��Top=�6�   $	��160��6�   $��16(�6�   �� 5+      -
   5        
 ��Name$
 btContinuar��5+      $��Añadir��6*   $
��Left=�6;   $��216,306,0,0q�6V   $	��Top=�6k   $	��110��6�   $��32��6�   $��16(�6�   �� 5,      -   5        $ lbInventarioActual��5,      $��Cantidad actual��60   $
��Left=�6J   $��
37,194,0,0q�6e   $	��Top=�6y   $	��133��6�   $��26��6�   $
��Bold"�6�   ���	#FF333742$��16(�6�   �� 5-      -   5        $
 btConsultar��5-      $��	Consultar��6*   $
��Left=�6>   $��216,128,0,0q�6Y   $	��Top=�6n   $	��110��6�   $��16(�6�   �� 5.      -   5        $ lbInventarioActual1��5.      $�� ��61   $
��Left=�6<   $��197,187,0,0q�6W   $	��Top=�6l   $	��160��6�   $��16(�6�   $��36��6�   5/      52      53      