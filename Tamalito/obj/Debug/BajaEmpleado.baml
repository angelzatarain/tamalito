   M S B A M L   `   `   `  ����C  ?Tamalito, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TamalitoTamalito  5   	       Tamalito.BajaEmpleado   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tamalito     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  BajaEmpleado��5   	   $	��415��6   $	��420��6+    � WindowStartupLocation$ CenterScreen=�67    � WindowStyle$
 None=�6\    � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      
������ ._�5      � ���	#FF455A64.+�5      �� -   5        $
��Left=�5      $��32��64   $��32��6?   $��9 0 0 0q�6K   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6\   $��0q�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�6.   5      �� 5      $��Center=�6   $��Center=�65   $��18(�6P   ���	#DDFFFFFF$
��Bold"�6u   $��Segoe UI)�6�   .��6�   Baja empleado6�   �� 5      -   5        $��Right=�5      $��32��65   $��32��6@   $��0 0 9 0q�6L   $ Depth3=�6]   $��0q�6�   .��5        $ WindowClose=�6.   5      5      5       � 5"   
   $��1��6   .+�5#      �� -   5         ��Name$ lbIdEmpleado��5#      $��Id Empleado��6*   $
��Left=�6@   $��	43,45,0,0q�6[   $	��Top=�6n   $
��Bold"�6�   �� 5$      -   5        $ lbNombre��5$      $��Nombre��6&   $
��Left=�67   $��	43,87,0,0q�6R   $	��Top=�6e   $��76��6}   $
��Bold"�6�   �� 5%      -   5        $ lbApellidoPaterno��5%      $��Apellido Paterno��6/   $
��Left=�6J   $��
43,126,0,0q�6e   $	��Top=�6y   $
��Bold"�6�   �� 5&      -   5        $ lbApellidoMaterno��5&      $��Apellido Materno
��6/   $
��Left=�6T   $��
43,167,0,0q�6o   $	��Top=�6�   $	��109��6�   $��26��6�   $
��Bold"�6�   �� 5'      -   5         ��Name$ tbIdEmpleado��5'      $
��Left=�6,   $��32��6G   $��
180,39,0,0q�6S   	 �� TextWrapping$
	 Wrap=�6g   $	��Top=�6{   $	��160��6�   $
��Bold"�6�   �� 5(      -	   5        $ tbNombre��5(      $
��Left=�6(   $��27��6C   $��
180,87,0,0q�6O   $
	 Wrap=�6c   $	��Top=�6w   $	��160��6�   $
��Bold"�6�   �� 5)      -
   5        $ tbApellidoPaterno��5)      $
��Left=�61   $��30��6L   $��180,126,0,0q�6X   $
	 Wrap=�6m   $	��Top=�6�   $	��160��6�   $
��Bold"�6�   �� 5*      -   5        $ tbApellidoMaterno��5*      $
��Left=�61   $��32��6L   $��180,161,0,0q�6X   $
	 Wrap=�6m   $	��Top=�6�   $	��160��6�   $
��Bold"�6�   �� 5+      -   5        $ lbMotivo��5+      $��Motivo��6&   $
��Left=�67   $��
43,221,0,0q�6R   $	��Top=�6f   $��76��6~   $
��Bold"�6�   �� 5,      -   5        $ tbMotivo��5,      $
��Left=�6(   $��42��6C   $��180,206,0,0q�6O   $
	 Wrap=�6d   $	��Top=�6x   $	��160��6�   $
��Bold"�6�   �� 5-      -   5        
 ��Name$
 btContinuar��5-      $��Realizar baja��6*   $
��Left=�6B   $��145,312,0,0q�6]   $	��Top=�6r   $	��118��6�   $
��Bold"�6�   5.      50      51      